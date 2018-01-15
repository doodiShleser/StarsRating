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
using BE;
using BL;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Star.xaml
    ///Specifically I coding for my app. The star functions in two different situations,
   /// for client that ranks his server and for server displays his rating status
    /// </summary>
    public partial class Star : UserControl
    {
        int idChild;//the client ID
        public Star()
        {
            InitializeComponent();
        }
        /// <summary>
        /// CTOR for star
        /// </summary>
        /// <param name="r">1 0r 0 for brush.color of star</param>
        /// <param name="id">0 for just present status of rating, not play as button</param>
        public Star(int r, int id=0) 
        {
            InitializeComponent();
            if (r == 1)
                myStar.Background = Brushes.Yellow;
            if (id == 0)
                myStar.IsEnabled = false;
            idChild = id;
        } 
        private void myStar_Click(object sender, RoutedEventArgs e)
        {
            Child c = new Child();//define Client
            if(idChild != 0)
                c = //... //in my app: BL_imp.GetInstance().getChild().Find(x=>x.ID == idChild);
            if (myStar.Background==Brushes.Yellow)
            {
                myStar.Background = Brushes.White;
                c.stars--;//he choose to decrease his rating for server
            }
            else
            {
                myStar.Background = Brushes.Yellow;
                c.stars++;//he choose to crease his rating for server
            }
            // update the change in specific client property//in my app:BL_imp.GetInstance().updateChild(c);
            
        }
    }
}
