namespace Decisions
{
    class Decisions 
    {

        bool love;

        public Decisions()
        {
            
        }

        public void decideif()
        {
            if(love)
            {
                Console.WriteLine("I Love You");
            }

            else 
            {
                Console.WriteLine("Still Love You");
            }
        }

        public void decideSwitch(int select)
        {
            switch(select)
            {
                case 1:
                case 2:
                    Console.WriteLine("Cute");                  // execute when any one is true.
                    break;

                case 3:
                    Console.WriteLine("Love");
                    break;

                //case 2==2: // Invalid
                //    break;

                case '2':
                    Console.WriteLine("String 2");
                    break;

                //case "2":   // Invalid                         // value successed by case must convertable to int.
                //    break;
                
                default :
                    Console.WriteLine("Love is Cute");          // run if no case block is executed. 
                    break;                                      // if the variable doesn't match to any constant.
            } 
        }

        public void ElseIf()
        {
            if(0==1)                  // must use a condition not a value Eg : if(0) -> invalid
            {
                Console.Write(0);
            }

            else if(0==0)
            {
                Console.WriteLine("else if");
            }

            else 
            {
                Console.WriteLine("else");
            }
        }
    }
}