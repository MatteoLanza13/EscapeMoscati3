using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.Json;




namespace EscapeMoscati3
{
    /// <summary>
    /// Interaction logic for RispostaAperta.xaml
    /// </summary>
    public partial class RispostaAperta : Window
    {
       
        public RispostaAperta()
        {
            InitializeComponent();
            Load();
        }
        
        private void Risposta_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DPrec_Click(object sender, RoutedEventArgs e)
        {
            Previous();
        
        }

        private void DSucc_Click(object sender, RoutedEventArgs e)
        {
            Next();
        }

        private void SuggerimentoBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
            
       
            public int ndomanda = 0;
           

              (string dom, string ris)[] domanda = {

                    ("d1","r1"),
                    ("d2","r2"),

                };
            public  void Load()
            {

                Update(domanda[ndomanda]);

            }


            public void Next()
            {
                if(ndomanda < domanda.Length-1){
                ndomanda++;
                Update(domanda[ndomanda]);
                }
            }

            public void Previous()
            {
                if(ndomanda > 0){
                ndomanda--;
                    Update(domanda[ndomanda]);
                }
            }
            public void Reset()
            {
                ndomanda = 0;
                Update(domanda[ndomanda]);
            }
            public void Update((string dom, string ris) domanda)
            {
                Domanda.Text=domanda.dom;
                Risposta.Text = domanda.ris;
                
            }
        


    }
}
