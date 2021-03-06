﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.ThreadsAndAsynchronyExamples.Slide24
{
   class Program
   {
      static void Main( string[] args )
      {
         Task<int> t = Task.Factory.StartNew( () =>
            {
               int k = 87;
               return 100 / ( k - 87 ); 
            }
         );

         try
         {
            t.Wait();
         }
         catch ( AggregateException ae )
         {
            foreach( Exception e in ae.InnerExceptions )
            {
               Console.WriteLine( e.Message );
            }
         }

         Console.ReadLine();
      }
   }
}
