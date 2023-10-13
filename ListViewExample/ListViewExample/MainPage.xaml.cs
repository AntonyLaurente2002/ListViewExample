﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item12.Clicked += async (sendr, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
            Item13.Clicked += async (sendr, e) =>
            {
                await Navigation.PushAsync(new ListViewCode());
            };
            Item14.Clicked += async (sendr, e) =>
            {
                await Navigation.PushAsync(new ListViewSource());
            };
        }
    }
    }
