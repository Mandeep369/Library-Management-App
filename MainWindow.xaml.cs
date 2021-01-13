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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setItemSources();
        }

        public void setItemSources()
        {

            BookRecord.ItemsSource = Library.allLibraryList;
             MemberName.ItemsSource = Membersmanager.allMembers;
        }
        
    //----------LendMedia Button Starts-----------
        private void LendMedia(object sender, RoutedEventArgs e)
        {
            if ((Media)BookRecord.SelectedItem != null || (LibraryMembers)MemberName.SelectedItem != null)
            {
                Media mediaList = (Media)BookRecord.SelectedItem;
                LibraryMembers membersList = (LibraryMembers)MemberName.SelectedItem;

                if (mediaList.Availability)
                {
                    showErrorDialoge(" Sorry! This Media is unavailable.");
                }
                else
                {
                    mediaList.Availability = !(mediaList.Availability);
                    mediaList.Borrower = membersList.Name;
                    RefreshDataGrid();
                }

            }
            else
            {
                showErrorDialoge("Please Select Both Member and Media Options");
            }

        }

        //ReturnMedia--------------
        private void ReturnMedia(object sender, RoutedEventArgs e)
        {
            if ((Media)BookRecord.SelectedItem != null)
            {
                Media mediaList = (Media)BookRecord.SelectedItem;
                if (mediaList.Availability)
                {
                    mediaList.Availability = !(mediaList.Availability);
                    mediaList.Borrower = "";
                    RefreshDataGrid();

                }
                else
                {
                    showErrorDialoge("This Media is not Lended");
                }
            }
            else
            {
                showErrorDialoge("Please Select Any Media");
            }
        }
        //-------------Media Info Button-------
        private void MediaInfo(object sender, RoutedEventArgs e)
        {
            if (BookRecord.SelectedItem != null)
            {

                //MediaInfo mediainfo = (MediaInfo)peopleGrid.SelectedItems[0];
                object currentContent = this.Content;
                Media data = (Media)BookRecord.SelectedItems[0];
                //DetailMediaInfo detailsinfo = new DetailMediaInfo(currentContent);
                MediaInfo page = new MediaInfo(currentContent, data);
                this.Content = page;
            }
        }
        //--------------Member Info Button-----------
        private void MemberInfo(object sender, RoutedEventArgs e)
        {
            if (MemberName.SelectedItem != null)
            {
                //MediaInfo mediainfo = (MediaInfo)peopleGrid.SelectedItems[0];
                object currentContent = this.Content;
                LibraryMembers list = (LibraryMembers)MemberName.SelectedItems[0];
                PageMembers page = new PageMembers(currentContent, list);
                this.Content = page;
            }
        }
        //-------Referesh Data Grid-----------
        public void RefreshDataGrid()
        {
            BookRecord.ItemsSource = null;
            BookRecord.ItemsSource = Library.allLibraryList.ToList();
        }

        public void RefreshMemberNameGrid()
        {
            MemberName.ItemsSource = null;

            MemberName.ItemsSource = Membersmanager.allMembers;

        }

        private void showErrorDialoge(string error)
        {

            MessageBox.Show(error, "ERROR", MessageBoxButton.OK);

        }
        //Modify Media Button-------
        private void ModifyMedia(object sender, RoutedEventArgs e)
        {
            if ((Media)BookRecord.SelectedItem != null)
            {
                object currentContent = this.Content;
                Media librarydata = (Media)BookRecord.SelectedItem;
                ModifyMedia newPage = new ModifyMedia(currentContent, librarydata);
                this.Content = newPage;
            }
            else
            {
                showErrorDialoge("Please select the media");
            }
        }
        //Modify Member Button
        private void ModifyMember(object sender, RoutedEventArgs e)
        {
            if ((Membersmanager)MemberName.SelectedItem != null)
            {
                object currentContent = this.Content;
                Media librarydata = (Media)MemberName.SelectedItem;
                ModifyMembers newPage = new ModifyMembers(currentContent, librarydata);
                this.Content = newPage;
            }
            else
            {
                showErrorDialoge("Please select the member");
            }
        }

       

    }
    }

