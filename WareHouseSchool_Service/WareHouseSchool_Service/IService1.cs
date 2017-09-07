using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WareHouseSchool_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //--------------------User functionality------------------
        [OperationContract]
        void Register(string firstName, string lastName, string emailAddress, string contactNumber, string password, string authenticationLecel);

        [OperationContract]
        bool login(string emailAdress, string password, out int userID, out string authinticationLevel);

        [OperationContract]
        List<User> getUsers();

        //--------------------Product functionality------------------
        [OperationContract]
        void addProductType(string productCategory, string productTypeName);

        [OperationContract]
        void updateProduct(int productId, int productTypeId, string description, double price, int quantity, string image64String);

        [OperationContract]
        void deleteProduct(int productId);

        [OperationContract]
        List<ProductType> getAllProductTypes();

        [OperationContract]
        void addProduct(int productTypeId, string description, double price, int quantity, string image64String);

        [OperationContract]
        List<Product> getAllProducts();

        [OperationContract]
        List<Product> getAllProductsByTypeId(int productTypeId);

        //-------------------Card Fuctionality--------------------------------------------------------
        [OperationContract]
        void addProductToCard(int productId, int ProductTypeId, int userId, int quantity, decimal price);

        [OperationContract]
        void removeProductFromCard(int cardId);

        [OperationContract]
        List<ProductCard> getAllProductsInCard();

        [OperationContract]
        List<ProductCard> getAllProductsInCardByProducId(int productId);

        [OperationContract]
        List<ProductCard> getAllProductsInCardByUserId(int userId);

        [OperationContract]
        List<ProductCard> getAllProductsInCardByProductTypeId(int prodyctTypeId);

        //-------------------------------------------------Order functionality------------------------------
        [OperationContract]
        void addOrder(int ProductID, int CardID, decimal OrderPrice, int userId, int productTypeId);

        [OperationContract]
        void updateOrderStatusClient(int orderId, int clientStatusId);

        [OperationContract]
        void updateOrderStatusBackend(int orderId, int backEndStatusId);

        [OperationContract]
        List<Order> getAllOders();

        [OperationContract]
        List<Order> getAllOrdersByUserId(int userId);

        //-----------------------------------------------Statuses Functionality-------------------------------

        [OperationContract]
        List<ClientStatuse> getAllClientStatus();

        [OperationContract]
        List<BackEndStatus> getAllBackEndStatus();
    }
}
