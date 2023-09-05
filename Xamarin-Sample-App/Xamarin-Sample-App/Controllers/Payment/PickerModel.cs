using System;
using Foundation;
using UIKit;

namespace Xamarin_Sample_App
{
	public class PickerModel : UIPickerViewModel
	{
        public string[] months = new string[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "Octobar", "November", "December"
        };

        public string[] years = new string[]
        {
            "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034"
        };

        public PickerModel()
        {
            
        }

        [Export("numberOfComponentsInPickerView:")]
        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            switch (pickerView.Tag)
            {
                case 1:
                    return months.Length;
                case 2:
                    return years.Length;
                default:
                    return 1;
            }
        }

        [Export("pickerView:titleForRow:forComponent:")]
        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                switch (pickerView.Tag)
                {
                    case 1:
                        return months[row];
                    case 2:
                        return years[row];
                    default:
                        return "";
                }
            else
                return row.ToString();
        }

    }
}

