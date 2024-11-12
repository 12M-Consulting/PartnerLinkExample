using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PartnerLinkExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetToken_Click(object sender, EventArgs e)
        {

            try
            {
                this.Enabled = false;
                lblProcess.Visible = true;
                using (var client = new HttpClient())
                {
                    string url = $"{txtUrl.Text}api/v1/auth/Authorize?userName={txtUserName.Text}&password={txtPwd.Text}";
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        txtToken.Text = JObject.Parse(responseBody)["token"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Enabled = true;
                lblProcess.Visible = false;
            }
            
     
        }

        private async void btnExample1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtToken.Text))
                {
                    MessageBox.Show("Please get token via given credentials");
                    return;
                }
                this.Enabled = false;
                lblProcess.Visible = true;
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtToken.Text);
                    string url = $"{txtUrl.Text}{txtExample1.Text}";
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        txtResult.Text = "Result: " + responseBody;

                    }
                    else
                    {
                        txtResult.Text = $"Error: {response.StatusCode}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Enabled = true;
                lblProcess.Visible = false;
            }
            

        }

        private async void btnExample2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtToken.Text))
                {
                    MessageBox.Show("Please get token via given credentials");
                    return;
                }
                this.Enabled = false;
                lblProcess.Visible = true;
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtToken.Text);
                    string url = $"{txtUrl.Text}{txtExample2.Text}";
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        txtResult.Text = "Result: " + responseBody;

                    }
                    else
                    {
                        txtResult.Text = $"Error: {response.StatusCode}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Enabled = true;
                lblProcess.Visible = false;
            }
            
            
        }
    }
}
