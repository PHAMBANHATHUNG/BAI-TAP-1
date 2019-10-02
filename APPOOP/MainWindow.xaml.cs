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

namespace APPOOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Student st1 = new Student("Minh");
            st1.Talk();
            Student st2 = new Student();
            st2.StudentName = "Dung";
            st2.Talk();

            List<Student> studentList = new List<Student>();
            // Nhập tên sinh viên thứ nhất             
            studentList.Add(new Student("Minh"));             // Nhập tên sinh viên thứ hai             
            studentList.Add(new Student("Hoa"));             // Nhập tên sinh viên thứ ba             
            studentList.Add(new Student("Dung"));  
            //Hiển thị thông tin các sinh viên trong ListBox             // với thuộc tính Name là lst  
            foreach (Student st in studentList) { lst.Items.Add(st.StudentName); }
        }

       
             
     }
}

