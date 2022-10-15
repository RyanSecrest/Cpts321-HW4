using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SpreadsheetEngine
{
    public abstract class Cell : INotifyPropertyChanged
    {
        protected int RowIndex { get; } = 0;
        protected int ColumnIndex { get; } = 0;
        protected string Text { get; } = "Default Text";
        protected string Value { get; } = "Default Value";
        public Cell()
        {           
        }

        public Cell(int rowIndex, int columnIndex, string text, string value)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Value = value;
            if (text != this.Text)
            {
                Text = text;
                NotifyPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class cellClass : Cell
    {
        
    }
}