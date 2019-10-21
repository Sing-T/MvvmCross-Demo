using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using TipCalc.Core.ViewModels;
using Xamarin.Forms;

namespace TipCalc.Forms.UI.Pages
{
    public partial class TipView : MvxContentPage<TipViewModel>
    {
        public TipView()
        {
            InitializeComponent();
        }
    }
}
