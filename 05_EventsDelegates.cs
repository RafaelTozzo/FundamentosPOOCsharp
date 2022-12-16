namespace FundamentosPOOCsharp
{
    public class EventsDelegates
    {
        public static void EventsDelegatesEx()
        {
            var room = new Room(3);

            room.RoomSoldOutEvent += OnRoomSoldOut;

            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut(object? sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }

        public class Room
        {
            public Room(int seats)
            {
                Seats = seats;
                seatsInUse = 0;
            }

            private int seatsInUse = 0;
            public int Seats { get; set; }

            public void ReserveSeat()
            {
                if (seatsInUse >= Seats)
                {
                    OnRoomSoldOut(EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("Assento reservado");
                }
                seatsInUse++;
            }

            public event EventHandler? RoomSoldOutEvent;

            protected virtual void OnRoomSoldOut(EventArgs e)
            {
                EventHandler? handler = RoomSoldOutEvent;
                handler?.Invoke(this, e);
            }
        }
    }
}