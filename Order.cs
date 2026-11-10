//Task 3
    class Order
    {
        public Product OrderedProduct;
        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (value == "Ordered" ||
                   value == "Packed" ||
                   value == "Dispatched" ||
                   value == "Delivered")
                {
                    state = value;
                }

                else
                {
                    state = "Ordered";
                }
            }
        }
        public Order(Product input1)
        {
            OrderedProduct = input1;
            state = "Ordered";
        }
    }