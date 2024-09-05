namespace Practica2.Ej2
{
    public class PhotoBook
    {
        protected int NumPages { get; set; }

        public PhotoBook(int numpages) 
        {
            NumPages = numpages;
        }
        public PhotoBook() 
        {
            NumPages = 16;
        }

        public int GetNumberPages() 
        { 
            return NumPages; 
        
        }

    }
}
