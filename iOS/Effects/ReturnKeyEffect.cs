using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using BetterForms.iOS.Effects;


[assembly:ResolutionGroupName("Brax")]
[assembly:ExportEffect(typeof(DoneKeyEffect), "DoneKeyEffect")]
namespace BetterForms.iOS.Effects
{
    public class DoneKeyEffect:PlatformEffect
    {
        public DoneKeyEffect()
        {
        }

        protected override void OnAttached()
        {
            try
            {
                (Control as UITextField).ReturnKeyType = UIReturnKeyType.Done;
            }
            catch
            {
                Console.WriteLine(string.Format("Can't apply effect to this control type of {0}", Control.GetType().Name));
            }
        }


        #region implemented abstract members of Effect

        protected override void OnDetached()
        {
            //do nothing
        }

        #endregion
    }
}

