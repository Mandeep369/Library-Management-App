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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for ModifyMembers.xaml
    /// </summary>
    /// 
    public partial class ModifyMembers : Page
    {
        object previousContent;
        //public enum setvaibility { Available, Not  };
        Media libraryMembers;
        public ModifyMembers(object _previousContent, Media data)
        {
            InitializeComponent();
            libraryMembers = data;
            previousContent = _previousContent;
            TextBox.Text = libraryMembers.Title;
        }

 
        private void BtnUpdate(object sender, RoutedEventArgs e)
        {
            libraryMembers.Title = TextBox.Text;

            ((MainWindow)Application.Current.MainWindow).RefreshMemberNameGrid();
            ((MainWindow)Application.Current.MainWindow).Content = previousContent;

        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            this.Content = previousContent;
        }
    }
}
