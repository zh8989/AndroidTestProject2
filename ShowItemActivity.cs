
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidTestProject2
{
    [Activity(Label = "ShowItemActivity")]
    public class ShowItemActivity : Activity
    {
        private TextView mTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ItemDetail);
            mTextView = FindViewById<TextView>(Resource.Id.DetailItem);
            mTextView.Text = this.Intent.GetStringExtra("Details");

        }
    }
}
