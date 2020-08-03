using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Work4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        BinaryTree binaryTree = new BinaryTree();
       
       
        

        public MainPage()
        {
            InitializeComponent();
           
            
        }
        
        
        private void insertButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNode.Text))
            {
                int value = int.Parse((entryNode.Text));
                binaryTree.insert(value);
                showTree.Text += entryNode.Text + " ";
                entryNode.Text = string.Empty;
            }
            else
            {
                this.DisplayAlert("Error","Ingrese un numero por favor","ok");
            }


        }


        private void preOrdenButton_Clicked(object sender, EventArgs e)
        {
            showOrden.Text ="preOrden ="+ binaryTree.preOrder(binaryTree.Root);
        }

        private void inOrdenButton_Clicked(object sender, EventArgs e)
        {
            showOrden.Text= "inOrden =" +  binaryTree.inOrder(binaryTree.Root);

        }

        private void postOrdenButton_Clicked(object sender, EventArgs e)
        {
            showOrden.Text = "postOrden =" + binaryTree.postOrder(binaryTree.Root);
        }
    }
}
