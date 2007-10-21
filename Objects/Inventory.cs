using System;
using System.Collections.Generic;

namespace Tibia.Objects
{
    /// <summary>
    /// Represents the player's inventory.
    /// </summary>
    public class Inventory
    {
        protected Client client;

        /// <summary>
        /// Create a new inventory object with the specified client.
        /// </summary>
        /// <param name="c"></param>
        public Inventory(Client c)
        {
            client = c;
        }

        /// <summary>
        /// Return a list of all the containers open in the inventory. Use getContainers().Count to find how many are open.
        /// </summary>
        /// <returns></returns>
        public List<Container> getContainers()
        {
            byte containerNumber = 0;
            List<Container> containers = new List<Container>();
            for (uint i = Memory.Addresses.Container.Start; i < Memory.Addresses.Container.End; i += Memory.Addresses.Container.Step_Container)
            {
                if (client.ReadByte(i + Memory.Addresses.Container.Distance_IsOpen) == 1)
                    containers.Add(new Container(client, i, containerNumber));
                containerNumber++;
            }
            return containers;
        }

        /// <summary>
        /// Find an item in the player's inventory.
        /// </summary>
        /// <param name="match">A delegate that returns true when a matched item is found.</param>
        /// <returns>Item object describing the item and its location.</returns>
        public Item findItem(Predicate<Item> match)
        {
            Item item = new Item(false);
            List<Container> containers = getContainers();
            foreach (Container c in containers)
            {
                item = c.getItems().Find(match);
                if (item != null) return item;
            }
            if (item == null) item = new Item(false);
            return item;
        }

        /// <summary>
        /// Find an item in the player's inventory by its id.
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns>Item object describing the item and its location.</returns>
        public Item findItem(uint itemId)
        {
            return findItem(delegate(Item i)
            {
                return i.Id == itemId;
            });
        }

        /// <summary>
        /// Find an item from a list in the player's inventory. Ex. findItem(new Tibia.Contstants.ItemList.Food()).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>Item object describing the item and its location.</returns>
        public Item findItem<T>(List<T> list) where T : Item
        {
            return findItem(delegate(Item i)
            {
                return i.isInList(list);
            });
        }

        /// <summary>
        /// Get the item at the specified location.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public Item getItem(ItemLocation location)
        {
            return null;
        }
    }
}