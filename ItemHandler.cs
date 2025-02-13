using Archipelago.MultiClient.Net.Helpers;
using Archipelago.MultiClient.Net;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APVacationSim
{
    public class ItemHandler
    {
        public static void HandleNewItem(ReceivedItemsHelper item)
        {
            if (item.PeekItem().ItemName == "Camera")
            {
                //Debug.Log("Unlock 1");
                Main.EnableCamera();
            }
            if (item.PeekItem().ItemName == "Vacation Beach Gate Unlock")
            {
                //Debug.Log("Unlock 2");
                Main.UnlockBeach();
            }
            if (item.PeekItem().ItemName == "Vacation Forest Gate Unlock")
            {
                //Debug.Log("Unlock 3");
                Main.UnlockForest();
            }
            if (item.PeekItem().ItemName == "Vacation Mountain Gate Unlock")
            {
                //Debug.Log("Unlock 4");
                Main.UnlockMountain();
            }
            if (item.PeekItem().ItemName == "Memory (Vacation Beach)")
            {
                //Debug.Log("Unlock 5");
                Main.AddBeachMemory();
            }
            if (item.PeekItem().ItemName == "Memory (Vacation Forest)")
            {
                //Debug.Log("Unlock 6");
                Main.AddForestMemory();
            }
            if (item.PeekItem().ItemName == "Memory (Vacation Mountain)")
            {
                //Debug.Log("Unlock 7");
                Main.AddMountainMemory();
            }

            item.DequeueItem();
        }
    }
}
