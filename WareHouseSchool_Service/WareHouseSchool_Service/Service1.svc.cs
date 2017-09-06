using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WareHouseSchool_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //----------------------user  functionality--------------------------------------------------------------------------
        public void Register(string firstName, string lastName, string emailAddress, string contactNumber, string password, string authenticationLevel)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            User user = new User();
            user.firstName = firstName;
            user.lastName = lastName;
            user.emailAdress = emailAddress;
            user.contactNumber = contactNumber;
            user.password = password;
            user.Adress = "Joburg";
            user.authenticationLevel = authenticationLevel;
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
        }

        public bool login(string emailAdress, string password, out int userID, out string authinticationLevel)
        {
            userID = -1;
            authinticationLevel = "";
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                User user = (from usr in db.Users where usr.emailAdress.Equals(emailAdress) select usr).Single();
                if (user != null)
                {
                    if (user.password.Equals(password))
                    {
                        userID = user.userId;
                        authinticationLevel = user.authenticationLevel;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            return false;
        }

        public List<User> getUsers()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<User> users = (from user in db.Users select user).ToList();
            return users;
        }

        //--------------------product fuctionality---------------------------------------------------------------------
        public void addProductType(string productCategory, string productTypeName)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            ProductType productType = new ProductType();
            productType.productCategory = productCategory;
            productType.productTypeName = productTypeName;
            db.ProductTypes.InsertOnSubmit(productType);
            db.SubmitChanges();
        }

        public List<ProductType> getAllProductTypes()
        {
            List<ProductType> allProductTypes = new List<ProductType>();
            DataClasses1DataContext db = new DataClasses1DataContext();

            foreach (var currentProductType in db.ProductTypes)
            {
                ProductType productType = new ProductType();
                productType.productTypeId = currentProductType.productTypeId;
                productType.productCategory = currentProductType.productCategory;
                productType.productTypeName = currentProductType.productTypeName;

                allProductTypes.Add(productType);
            }
            return allProductTypes;
        }

        public void addProduct(int productTypeId, string description, double price, int quantity, string image64String)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Product product = new Product();
            product.ProductTypeId = productTypeId;
            product.Date = DateTime.Now;
            product.Description = description;
            product.Price = Convert.ToDecimal(price);
            product.Quantity = quantity;
            product.Image64String = image64String;
            db.Products.InsertOnSubmit(product);
            db.SubmitChanges();
        }

        public List<Product> getAllProducts()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<Product> proc = (from product in db.Products select product).ToList();
            return proc;
        }

        public List<Product> getAllProductsByTypeId(int productTypeId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return (from product in db.Products where product.ProductTypeId.Equals(productTypeId) select product).ToList();
        }


        //---------------------------Card functionality ------------------------------------------
        public void addProductToCard(int productId, int ProductTypeId, int userId, int quantity)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            ProductCard card = new ProductCard();
            card.ProductId = productId;
            card.ProductTypeId = ProductTypeId;
            card.DateTime = DateTime.Now;
            card.UserId = userId;
            card.Quantity = quantity;
            card.isRemoved = "false";
            db.ProductCards.InsertOnSubmit(card);
            db.SubmitChanges();
       }

        public void removeProductFromCard(int cardId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            foreach (var card in db.ProductCards)
            {
                if (card.CardId == cardId)
                {
                    card.isRemoved = "true";
                    db.SubmitChanges();
                }
            }
        }

        public List<ProductCard> getAllProductsInCard()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<ProductCard> card = (from current in db.ProductCards select current).ToList();
            return card;
        }

        public List<ProductCard> getAllProductsInCardByProducId(int productId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return (from current in db.ProductCards where current.ProductId.Equals(productId) select current).ToList();
        }

        public List<ProductCard> getAllProductsInCardByUserId(int userId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return (from current in db.ProductCards where current.UserId.Equals(userId) select current).ToList();
        }

        public List<ProductCard> getAllProductsInCardByProductTypeId(int prodyctTypeId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return (from current in db.ProductCards where current.UserId.Equals(prodyctTypeId) select current).ToList();
        }

        public void DeleteProductInCard(int cardId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            ProductCard productToDelete = (from p in db.ProductCards where cardId == p.CardId select p).Single();
            db.ProductCards.DeleteOnSubmit(productToDelete);
            db.SubmitChanges();
        }

    //--------------------------------------------Order functionality-----------------------------------------------------

    public void addOrder(int ProductID, int CardID, decimal OrderPrice, int userId, int productTypeId)
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Order order = new Order();
        order.ProductID = ProductID;
        order.CardID = CardID;
        order.OrderPrice = OrderPrice;
        order.UserId = userId;
        order.ProductTypeId = productTypeId;
        order.ClientStatusId = 1;
        order.BackEndStatusId = 1;
        order.OrderDate = DateTime.Now;
        db.Orders.InsertOnSubmit(order);
        db.SubmitChanges();
        DeleteProductInCard(CardID);
    }

    public void updateOrderStatusClient(int orderId, int clientStatusId)
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        foreach (var order in db.Orders)
        {
            if (order.OrderId == orderId)
            {
                order.ClientStatusId = clientStatusId;
                db.SubmitChanges();
            }
        }
    }

    public void updateOrderStatusBackend(int orderId, int backEndStatusId)
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        foreach (var order in db.Orders)
        {
            if (order.OrderId == orderId)
            {
                order.BackEndStatusId = backEndStatusId;
                db.SubmitChanges();
            }
        }
    }

    public List<Order> getAllOders()
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        return (from current in db.Orders select current).ToList();
    }

    public List<Order> getAllOrdersByUserId(int userId)
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        return (from current in db.Orders where current.UserId.Equals(userId) select current).ToList();
    }


    //-----------------------------------------------Statuses Functionality----------------------------------------
    public List<ClientStatuse> getAllClientStatus()
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        return (from current in db.ClientStatuses select current).ToList();
    }

    public List<BackEndStatus> getAllBackEndStatus()
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        return (from current in db.BackEndStatus select current).ToList();
    }
}
}