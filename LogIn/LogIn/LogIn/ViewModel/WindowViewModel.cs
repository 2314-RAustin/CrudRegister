using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace LogIn
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    class WindowViewModel : BaseViewModel
    {
        #region Private Member
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window nWindow; 
        /// The margin around the window to allow for a drop shadow
        private int mOuterMarginSize = 10;
        /// The radius of the edges of the window
        private int mWindowRadius = 10;
        #endregion
        #region Public Properties
        //The smallest Width the window can do
        public double WindowMinimumWidth { get; set; } = 600;
        //The smallest Height the window can do
        public double WindowMinimumHeight { get; set; } = 600;
    

       /// The size of the resize border around the window
        public int ResizeBorder { get { return Borderless ? 0 : 6; } }
        /// The size of the resize border arround the window, taking into account the outer margin
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }
        /// The padding of the inner content of the main window
        public Thickness InnerContentPadding { get; set; } = new Thickness(0) ;
        /// The margin around the window to allow a drop shadow
        public int OuterMarginSize
        {
            get
            {
                return nWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }
        /// The margin around the window to allow a drop shadow
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }
        /// The radius of the edges of the window
        public int WindowRadius
        {
            get
            {
                return nWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }
        /// The cornerradius of the edges of the window
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }
        //The height of the tittle bar/ caption of the window
        public int TitleHeight { get; set; } = 45;
        //The height of the tittle bar/ caption of the window
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        public ApplicationPages CurrentPage { get; set; } = ApplicationPages.LogIn;

        #endregion

        #region Commands
        //The command to minimize the window
        public ICommand MinimizeCommand { get; set; }
        //The command to maximize the window
        public ICommand MaximizeCommand { get; set; }
        //The command to close the window
        public ICommand CloseCommand { get; set; }
        //The command to menu the window
        public ICommand MenuCommand { get; set; }
        public bool Borderless { get; private set; }




        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary> 
        public WindowViewModel(Window window)
        {
            nWindow = window;

            //Listen out for the window resizing
            nWindow.StateChanged+=(sender, e)=>
            {
                //Fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };

            //Create commmands
            MinimizeCommand = new RelayCommand(() => nWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => nWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => nWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(nWindow, GetMousePosition()));

        }
        #endregion

        #region Private Helpers
    

        private  Point GetMousePosition()
        {

           var position= Mouse.GetPosition(nWindow);
            return new Point(position.X + nWindow.Left, position.Y + nWindow.Top);

        }

        #endregion
    }
}
