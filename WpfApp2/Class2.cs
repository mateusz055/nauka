﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Class2
    {
        var downloadBlock = new TransformBlock<int, Try<int>>(construct => Try.Create(() =>
        {
            //TUTAJ COŚ ZMIEN
            //TUTAJ COŚ ZMIEN
            //TUTAJ COŚ ZMIEN
            //SomeProcessingMethod();
            return 1;
        }));
        var processBlock = new TransformBlock<Try<int>, Try<int>>(construct => construct.Map(value =>
        {
            //SomeProcessingMethod();
          
        }));
        var resultsBlock = new ActionBlock<Try<int>>(construct =>
        {
            if (co
            {
                var e
                {
                    fdsfsdfsdfsdfsd
                        //_notificationService.NotifyUser("OMG, my dear sir, I think I messed something up:/"
                        //Register that this item was faulfdsfdfsfsdfsdfdsf                          
                        break;
                    de
                        break;
                gfgfdgfdgfdg
                }
            }
        });
        public static double FindSmallestNum(double[] arr)
        {
            doubl
            for (int x = 0; x < arr.Length - 1; x++)
            {
                if (arr[x] >= arr[x + 1])
                {
                    if (max >= arr[x + 1])
                    {
                        max = arr[x + 1];
                    }
                }
                else if (max >= arr[x])
                {
                    max = arr[x];
                }
                else
                {
                    max = arr[x];
                }
            }
            return max;
        }
    }
}
