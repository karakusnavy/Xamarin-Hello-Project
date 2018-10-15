using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidHello
{
    [Activity(Label = "AndroidHello", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {//FindViewById <Button>(Resource.Id.btn1);
        Button btn;
        protected override void OnCreate(Bundle bundle)
        {
         
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += Btn_Click;
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
        TextView txt;
        private void Btn_Click(object sender, System.EventArgs e)
        {
            txt = FindViewById<TextView>(Resource.Id.textView1);
            txt.Text = "Thanks!";
        }
    }
}

