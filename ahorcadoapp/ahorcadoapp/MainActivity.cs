using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace ahorcadoapp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText letra = FindViewById<EditText>(Resource.Id.txtletra);
            Button botonletra = FindViewById<Button>(Resource.Id.btnletra);
            TextView res = FindViewById<TextView>(Resource.Id.lblres);
            EditText palabra = FindViewById<EditText>(Resource.Id.txtpalabra);
            Button botonpalabra = FindViewById<Button>(Resource.Id.btnpal);
            ImageView imagen = FindViewById<ImageView>(Resource.Id.image);
           
            void actualizar ()
            {
                switch (ahorcadoapp.Ahorcado.getInstancia().Estado)
                {
                    case 0:
                        break;
                    case 1:
                        imagen.SetImageResource(Resource.Drawable.uno);
                        break;
                    case 2:
                        imagen.SetImageResource(Resource.Drawable.dos);
                        break;
                    case 3:
                        imagen.SetImageResource(Resource.Drawable.tres);
                        break;
                    case 4:
                        imagen.SetImageResource(Resource.Drawable.cuatro);
                        break;
                    case 5:
                        imagen.SetImageResource(Resource.Drawable.cinco);
                        break;
                    case 6:
                        imagen.SetImageResource(Resource.Drawable.seis);
                        break;
                    case 7:
                        imagen.SetImageResource(Resource.Drawable.siete);
                        break;
                    case 8:
                        imagen.SetImageResource(Resource.Drawable.ocho);
                        break;
                }
            }

            botonletra.Click += (sender, e) =>
            {
                char l = letra.Text[0];
                string r = ahorcadoapp.Ahorcado.getInstancia().Buscar(l);
                res.Text = r;
                actualizar();
            };
            botonpalabra.Click += (sender, e) =>
              {
                  string p = palabra.Text;
                  string rp = ahorcadoapp.Ahorcado.getInstancia().BuscarPalabra(p);
                  res.Text = rp;
                  actualizar();
              };
        }
    }
}