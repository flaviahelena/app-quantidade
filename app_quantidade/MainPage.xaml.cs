using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_quantidade
{
    public partial class MainPage : ContentPage
    {
        int qtd = 1;
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void aumentar(object sender, EventArgs e)
        {
            qtd++;
            lblQuantidade.Text = qtd.ToString();
        }

        private void diminuir(object sender, EventArgs e)
        {
            if (qtd != 0)
            {
                qtd--;
                lblQuantidade.Text = qtd.ToString();
            }
            
        }
    }
}
