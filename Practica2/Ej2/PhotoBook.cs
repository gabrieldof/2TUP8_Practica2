namespace Practica2.Ej2
{
    public class PhotoBook
    {
        protected int NumPages { get; set; }

        public PhotoBook(int numpages) 
        {
            NumPages = numpages;
        }
        public PhotoBook() : this(16)
        {
            
        }

        public int GetNumberPages() 
        { 
            return NumPages; 
        
        }

    }
}
