using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaFinalOdevi.Models
{
    public class Notes : INotifyPropertyChanged
    {

        private string id;
        private string noteContent;
        private string title;
        private DateTime date;
        private TimeSpan time;
        private bool isCompleted;

        public Notes()
        {
            // Varsayılan değerler
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now;
            Time = DateTime.Now.TimeOfDay;
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public string Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        public string NoteContent
        {
            get => noteContent;
            set
            {
                noteContent = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }

        public TimeSpan Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }

        public bool IsCompleted
        {
            get => isCompleted;
            set
            {
                isCompleted = value;
                OnPropertyChanged();
            }
        }



    }
}