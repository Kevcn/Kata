using System;

namespace ExceptionHandling
{
    public class Worker
    {


        public void Call()
        {
            try
            {
                Layer1();
            }
            catch (Exception e)
            {
                Console.WriteLine("logging can be done at this level, while the exception is getting passed up the chain");
                
                // We could just catch and handle the exception here, 
                // but if we want to partially handle it as well as bubble the exception up to fully handle it,
                // we could use throw
                
                throw;
            }
            finally
            {
                Console.WriteLine("Close connection or somer");
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
            throw new CustomException("Error message frp, cistp, exception!");
        }
    }

    public class CustomException : Exception
    {
        public CustomException()
        {
            
        }
        
        public CustomException(string message)
        {
            
        }
    }
}