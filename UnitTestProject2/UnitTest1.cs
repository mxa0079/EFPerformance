using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        static int ItemsToInsert = 200;

        IList<string> TextOptionsData = new List<string>(){
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4",
            "MNOnghbf noevboe"
        };

        IList<TextOption>[] TextOptionsEntities = new IList<TextOption>[ItemsToInsert];

        [TestMethod]
        public void Write_Test()
        {
            var DB = new DB();

            

            var VariableSerializer = new Variable(){
                Name="Variable",
                TextOptions = TextOptionsData
            };

            var VariableJson = new VariableJson()
            {
                Name = "Variable",
                TextOptions = TextOptionsData
            };

            for (int i = 0; i < ItemsToInsert; i++)
            {
                TextOptionsEntities[i] = 
                        new List<TextOption>()
                            {
                                new TextOption(){Text="Option 1"},
                                new TextOption(){Text="Option 2"},
                                new TextOption(){Text="Option 3"},
                                new TextOption(){Text="Option 4"},
                                new TextOption(){Text="MNOnghbf noevboe"}
                            };
            }

            VariableEntities[] VariableEntitiesArray = new VariableEntities[ItemsToInsert];

            for (int i = 0; i < ItemsToInsert; i++)
            {
                VariableEntitiesArray[i] = new VariableEntities()
                {
                    Name="Variable",
                    TextOptions = TextOptionsEntities[i]
                };
            }

            ///Initialize TextOptions
            

            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < ItemsToInsert; i++)
            {
                DB.Variables_String_Serializer.Add(VariableSerializer);
                DB.SaveChanges();
            }
            sw.Stop();

            Console.WriteLine("Time to write entities using string serializer: " + sw.Elapsed.Milliseconds + " miliseconds");

            sw.Reset();

            sw.Start();
            for (int i = 0; i < ItemsToInsert; i++)
            {
                DB.Variable_Json_Serializer.Add(VariableJson);
                DB.SaveChanges();
            }
            sw.Stop();

            Debug.WriteLine("Time to write entities using json serializer: " + sw.Elapsed.Milliseconds + " miliseconds");

            sw.Reset();

            sw.Start();
            for (int i = 0; i < ItemsToInsert; i++)
            {
                DB.Variables_Entity.Add(VariableEntitiesArray[i]);
                DB.SaveChanges();
            }
            sw.Stop();

            Debug.WriteLine("Time to write entities using multiple entities: " + sw.Elapsed.Milliseconds + " miliseconds");

        }
    }
}
