﻿using CreditCardUISample.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditCardUISample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class CreditCardPage : ContentPage
    {
        public CreditCardPage()
        {
            InitializeComponent();
            this.BindingContext = new CreditCardPageViewModel();
        }
    }
}