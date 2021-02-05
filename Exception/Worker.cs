using System;

namespace ExceptionDemo
{
    public class Worker
    {


        public void Call()
        {
            try
            {
                Layer1();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        
        
        
        
        private void Layer1(){
            Layer2();
        }
        
        private void Layer2()
        {
            Layer3();
        }
        
        private void Layer3()
        {
            throw new 
        }
        
        
    }

    public class CustomException : Exception
    {
        
    }
    
}