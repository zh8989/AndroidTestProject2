using System;
using System.Collections.Generic;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace AndroidTestProject2
{
    public class ItemAdapter : RecyclerView.Adapter
    {
        private List<Item> mItems;
        public event EventHandler<int> ItemClick;
        public override int ItemCount
        {
            get { return mItems.Count; }
        }

        public ItemAdapter(List<Item> Items)
        {
            mItems = Items;
        }

        public void OnItemClick(int postion)
        {
            if (ItemClick != null)
                ItemClick(this, postion);
        }


        public class ItemRowViewHolder : RecyclerView.ViewHolder
        {

            public View ItemRowView { get; set; }
            public TextView ItemName { get; set; }

            public ItemRowViewHolder(View view, Action<int> listner) : base(view)
            {
                ItemRowView = view;
                view.Click += (sender, e) => listner(base.AdapterPosition); 
            }

        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {     
            ItemRowViewHolder mHolder = holder as ItemRowViewHolder;
            mHolder.ItemName.Text = mItems[position].Name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //Create Row for each view
            View row = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.RecyclerViewRow, parent, false);
            TextView tName = row.FindViewById<TextView>(Resource.Id.itemName);
            ItemRowViewHolder ViewHolder = new ItemRowViewHolder(row,OnItemClick)
            {
                ItemName = tName
            };
            return ViewHolder;

        }

    }
}
