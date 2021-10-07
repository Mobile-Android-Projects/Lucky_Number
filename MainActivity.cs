using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekBar;
        Button rollBtn;
        TextView resultTxtView;

        Random random;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            rollBtn = FindViewById<Button>(Resource.Id.rollButton);
            resultTxtView = FindViewById<TextView>(Resource.Id.resultTextView);

            //create instance of random number generator
            random = new Random();

            rollBtn.Click += RollBtn_Click;
        }

        private void RollBtn_Click(object sender, System.EventArgs e)
        {
            int luckyNumber = random.Next(seekBar.Progress) + 1;
            resultTxtView.Text = luckyNumber.ToString();
        }
    }
}