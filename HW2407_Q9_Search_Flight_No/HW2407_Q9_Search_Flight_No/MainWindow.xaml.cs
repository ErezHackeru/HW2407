using FlightsSystem;
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

namespace HW2407_Q9_Search_Flight_No
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel = new MainWindowViewModel();
        static ILoginToken IloginAnonymous = FlyingCenterSystem.GetFlyingCenterSystemInstance().Login("NoMatch", "1111");
        AnonymousUserFacade anonymousUserFacade = (AnonymousUserFacade)FlyingCenterSystem.GetFlyingCenterSystemInstance().GetFacade(IloginAnonymous);
        // Flight no Exist in DB: 40087

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
                
        private void MyButn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Ft.Origin_Country_Code = anonymousUserFacade.GetFlightByID(Convert.ToInt32(Mytxtbx.Text)).Origin_Country_Code.ToString();
        }
    }
}
