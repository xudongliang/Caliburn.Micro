﻿using System;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Hello.Forms.Views;
using Xamarin.Forms;

namespace Hello.Forms
{
    public class App : FormsApplication
    {
        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            DisplayRootView<LoginView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigtionService>(new NavigationPageAdapter(navigationPage));
        }
    }
}
