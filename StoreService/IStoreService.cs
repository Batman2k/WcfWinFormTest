using System.Collections.Generic;
using System.ServiceModel;
using StoreService.Models;

namespace StoreService
{
    [ServiceContract]
    public interface IStoreService
    {
        [OperationContract]
        Article ReturnArticleById(int id);

        [OperationContract]
        List<Article> ReturnAllArticles();

        [OperationContract]
        void AddOrUpdateArticle(Article article);

        [OperationContract]
        void AddOrUpdateOrder(Order order, List<OrderItem> orderlist);

        [OperationContract]
        Order SearchOrderById(int orderid);

        [OperationContract]
        List<OrderItem> ReturnAllOrderItemsByfkKey(int fkOrderId);

        [OperationContract]
        void RemoveOrderById(int id);

        [OperationContract]
        void RemoveArticleById(int id);

        [OperationContract]
        List<Order> ReturnAllActiveOrders();

        [OperationContract]
        List<Order> ReturnAllSentOrders();

        [OperationContract]
        void UpdateOrderToSent(Order order);

        [OperationContract]
        List<User> ReturnAllUsers();

        [OperationContract]
        void AddOrUpdateUser(User user);

        [OperationContract]
        void RemoveUserById(int id);

        [OperationContract]
        List<Order> ReturnAllOrderByUser(string userName);
    }
}