private static DateTime Delay(int MS) //delay
        {
            // More effective then Thread and Timer
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {

                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
