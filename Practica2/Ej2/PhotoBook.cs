namespace Practica2.Ej2
{
    public class PhotoBook
    {
        
        public int Id { get; }
        protected int NumPages { get; set; }

        static int cont = 0;

        public PhotoBook(int numpages) 
        {
            NumPages = numpages;
            Id = GetId();
        }
        public PhotoBook() : this(16)
        {
            
        }

        public int GetNumberPages() 
        { 
            return NumPages; 
        
        }

        static int GetId()
        {
            return ++cont;
        }

    }
}
