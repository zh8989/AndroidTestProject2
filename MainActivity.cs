using Android.App;
using Android.Widget;
using Android.OS;
using static Android.Support.V7.Widget.RecyclerView;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using System;
using Android.Content;

namespace AndroidTestProject2
{
    [Activity(Label = "AndroidTestProject2", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private RecyclerView mRecyclerView;
        private LinearLayoutManager mLinerLayoutManeger;
        private ItemAdapter mAdapter;
        private List<Item> Items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.itemRecyclerView);
            Items = new List<Item>();
            AddSampleData();
            mLinerLayoutManeger = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLinerLayoutManeger);
            mAdapter = new ItemAdapter(Items);
            mAdapter.ItemClick += OnItemClicked;
            mRecyclerView.SetAdapter(mAdapter);

        }

        private void OnItemClicked(object sender, int position)
        {
            Intent intent = new Intent(this, typeof(ShowItemActivity));
            intent.PutExtra("Details",Items[position].Name);
            StartActivity(intent);
            
        }
        
        private void AddSampleData()
        {
            Items.Add(new Item("Item1"));
            Items.Add(new Item("Item2"));
            Items.Add(new Item("Item3"));
            Items.Add(new Item("Item4"));
            Items.Add(new Item("Item5"));
            Items.Add(new Item("Item6"));
            Items.Add(new Item("Item7"));
            Items.Add(new Item("Item8"));
            Items.Add(new Item("Item9"));
            Items.Add(new Item("Item10"));

        }
    }
}

