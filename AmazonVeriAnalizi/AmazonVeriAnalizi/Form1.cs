using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.IO;
using System.Net.Http;

namespace AmazonVeriAnalizi
{
    public partial class Form1 : Form
    {
        private ChromeDriver amazon;

        public Form1()
        {
            InitializeComponent();
        }

        private Thread amazonThread;
        private bool isActive = false;
        private bool isDetay = false;
        private bool isÖzellik = false;

        #region Chrome Creat
        private void chromeCreat()
        {
            // Options
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--headless");

            // Servics
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);
            service.HideCommandPromptWindow = true;

            // Manager
            amazon = new ChromeDriver(service, options);
            amazon.Navigate().GoToUrl(textBox1.Text);
            Thread.Sleep(500);

            try
            {
                IWebElement element = amazon.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div/div/form/div[1]/div/div/div[2]/div/div[2]/a"));
                element.Click();

                //*[@id="headingFour"]/h2/button
            }
            catch
            {
                
            }

            isActive = true;
        }
        #endregion

        #region Başlat
        private void StartAmazonThread()
        {
            amazonThread = new Thread(chromeCreat);
            amazonThread.Start();
        }

        private void CheckIsActive()
        {
            while (true)
            {
                if (isActive)
                {
                    MessageBox.Show("İşlem tamamlandı!");

                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Cursor = Cursors.Default;

                        label1.Visible = false;
                        baslikBTN.Enabled = true;
                        özellikBTN.Enabled = true;
                        detayBTN.Enabled = true;
                        resimBTN.Enabled = true;

                    });

                    break; 
                }
                Thread.Sleep(1000); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("URL alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            label1.Visible = true;
            button2.Enabled = false;

            StartAmazonThread();

            Thread checkIsActiveThread = new Thread(CheckIsActive);
            checkIsActiveThread.Start();
        }
        #endregion

        #region Başlık Çek
        private void baslikBTN_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Başlık Çek";
            özellikText.Visible = false;
            detayText.Visible = false;
            resimText.Visible = false;

            baslikText.Visible = true;

            try
            {
                IWebElement element = amazon.FindElement(By.XPath("//*[@id=\"productTitle\"]"));
                string text = element.Text;
                baslikText.Text = text;
            }
            catch { MessageBox.Show("Bu Ürünün Başlığı Çekilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Özellik Çek
        private void özellikBTN_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Özellik Çek";
            baslikText.Visible = false;
            detayText.Visible = false;
            resimText.Visible = false;

            özellikText.Visible = true;

            try
            {
                IWebElement divElement = amazon.FindElement(By.XPath("//*[@id='productOverview_feature_div']/div"));
                IWebElement tableElement = divElement.FindElement(By.XPath(".//table"));
                IWebElement tbodyElement = tableElement.FindElement(By.XPath(".//tbody"));

                IList<IWebElement> rows = tbodyElement.FindElements(By.XPath(".//tr"));

                foreach (IWebElement row in rows)
                {
                    IList<IWebElement> cells = row.FindElements(By.TagName("td"));

                    foreach (IWebElement cell in cells)
                    {
                        string cellText = cell.Text;
                        özellikText.AppendText(cellText + "\t");
                    }
                    özellikText.AppendText(Environment.NewLine);
                    isÖzellik = true;
                }
            }
            catch
            {
                MessageBox.Show("Bu Ürünün Özellikleri Yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                isÖzellik = false;
            }
        }
        #endregion

        #region Detaylı Özellik Çek
        private void detayBTN_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Detay Çek";
            baslikText.Visible = false;
            özellikText.Visible = false;
            resimText.Visible = false;

            detayText.Visible = true;

            try
            {
                IWebElement divElement = amazon.FindElement(By.XPath("//*[@id='prodDetails']/div/div[1]/div[1]/div/div[2]/div/div"));
                IWebElement tableElement = divElement.FindElement(By.TagName("table"));
                IWebElement tbodyElement = tableElement.FindElement(By.TagName("tbody"));

                IList<IWebElement> rows = tbodyElement.FindElements(By.TagName("tr"));

                foreach (IWebElement row in rows)
                {
                    IList<IWebElement> headerCells = row.FindElements(By.TagName("th"));
                    foreach (IWebElement headerCell in headerCells)
                    {
                        detayText.AppendText("Header: " + headerCell.Text + "\t");
                    }

                    IList<IWebElement> dataCells = row.FindElements(By.TagName("td"));
                    foreach (IWebElement dataCell in dataCells)
                    {
                        detayText.AppendText("Data: " + dataCell.Text + "\t");
                    }

                    detayText.AppendText(Environment.NewLine);
                    isDetay = true;
                }
            }
            catch
            {
                MessageBox.Show("Bu Ürünün Detaylı Özellikleri Yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                isDetay = false;
            }
        }
        #endregion

        #region Resim Çek
        private void resimBTN_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Resim İndirme ve Kaydetme";
            baslikText.Visible = false;
            özellikText.Visible = false;
            detayText.Visible = false;

            resimText.Visible = true;

            IList<IWebElement> imgElements = amazon.FindElements(By.XPath("//*[@id='altImages']//img"));

            foreach (IWebElement imgElement in imgElements)
            {
                string imgSrc = imgElement.GetAttribute("src");
                resimText.AppendText(imgSrc + Environment.NewLine);
            }          
        }
        #endregion

        #region Kaydet Butonu
        private async void kaydetBTN_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Kaydedilecek yeri seçin";
                dialog.RootFolder = Environment.SpecialFolder.Desktop;
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    string selectedPath = dialog.SelectedPath;
                    string folderName = baslikText.Text;
                    string folderPath = Path.Combine(selectedPath, folderName);

                    string imageFolderPath = Path.Combine(selectedPath, "image");
                    Directory.CreateDirectory(imageFolderPath);

                    try
                    {
                        Directory.CreateDirectory(folderPath);
                        string FilePath = Path.Combine(folderPath, "url.txt");
                        string resimFilePath = Path.Combine(folderPath, "resimUrls.txt");

                        if(isDetay)
                        {
                            string detaylıÖzellik = Path.Combine(folderPath, "detaylıÖzellikler.txt");

                            #region Resim URL lerini Yazma
                            using (StreamWriter writer = new StreamWriter(detaylıÖzellik))
                            {
                                foreach (string det in detayText.Lines)
                                {
                                    writer.WriteLine(det);
                                }
                            }
                            #endregion
                        }

                        if (isÖzellik)
                        {
                            string özellik = Path.Combine(folderPath, "özellikleri.txt");

                            #region Resim URL lerini Yazma
                            using (StreamWriter writer = new StreamWriter(özellik))
                            {
                                foreach (string öz in özellikText.Lines)
                                {
                                    writer.WriteLine(öz);
                                }
                            }
                            #endregion
                        }

                        #region URL DOSYA YAZMA
                        using (StreamWriter writer = new StreamWriter(FilePath))
                        {
                            writer.Write(textBox1.Text);
                        }
                        #endregion

                        #region Resim URL lerini Yazma
                        using (StreamWriter writer = new StreamWriter(resimFilePath))
                        {
                            foreach (string url in resimText.Lines)
                            {
                                writer.WriteLine(url);
                            }
                        }
                        #endregion

                        #region Resimleri İndirme
                        int count = 1;
                        foreach (string url in resimText.Lines)
                        {
                            if (Uri.TryCreate(url, UriKind.Absolute, out Uri validUri))
                            {
                                string fileName = Path.GetFileName(url);
                                string filePath = Path.Combine(imageFolderPath, $"{count}_{fileName}");

                                using (HttpClient client = new HttpClient())
                                {
                                    byte[] imageBytes = await client.GetByteArrayAsync(validUri); // validUri kullan
                                    File.WriteAllBytes(filePath, imageBytes);
                                }
                                count++;
                            }
                            else { }
                        }
                        #endregion

                        #region image klasörünü taşıma
                        try
                        {
                            if (!Directory.Exists(folderPath))
                            {
                                Directory.CreateDirectory(folderPath);
                            }

                            Directory.Move(imageFolderPath, Path.Combine(folderPath, "image"));

                            MessageBox.Show("Fotoğraflar başarıyla indirildi ve kaydedildi.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                        #endregion
                    }
                    catch
                    {
                        MessageBox.Show("hata");
                    }
                }
            }
        }
        #endregion
    }
}
