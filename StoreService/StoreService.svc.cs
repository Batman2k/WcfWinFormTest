using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using StoreService.Models;

namespace StoreService
{
    public class StoreService : IStoreService
    {

        public Article ReturnArticleById(int id)
        {
            try
            {
                using (var context = new StoreDb())
                {
                    return context.Articles.FirstOrDefault(o => o.Articleid == id);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }

        }

        public List<Article> ReturnAllArticles()
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.Articles.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public Order SearchOrderById(int orderid)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.Orders.FirstOrDefault(o => o.OrderId == orderid);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public List<OrderItem> ReturnAllOrderItemsByfkKey(int fkOrderId)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.OrderItems.Where(o => o.fkOrderId == fkOrderId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public void RemoveOrderById(int id)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    var removeId = new Order { OrderId = id };
                    context.Entry(removeId).State = EntityState.Deleted;
                    context.OrderItems.RemoveRange(context.OrderItems.Where(o => o.fkOrderId == id));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public void RemoveArticleById(int id)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    var removeId = new Article { Articleid = id };
                    context.Entry(removeId).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public List<Order> ReturnAllActiveOrders()
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.Orders.Where(o => o.ShippingDate == null).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public List<Order> ReturnAllSentOrders()
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.Orders.Where(o => o.ShippingDate != null).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public void UpdateOrderToSent(Order order)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    order.ShippingDate = DateTime.Now;
                    context.Entry(order).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public List<User> ReturnAllUsers()
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }
        //TODO FIX UPDATING
        public void AddOrUpdateUser(User user)
        {
           
            try
            {
                using (var context = new StoreDb())
                {

                    var userExits = context.Users.FirstOrDefault(o => o.UserName == user.UserName);
                    if (userExits != null)
                    {
                        if (userExits.Id == user.Id)
                        {
                            context.Entry(user).State = EntityState.Modified;
                        }
                    }
                    else
                    {
                        context.Entry(user).State = EntityState.Added;
                    }
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }
        
        public void RemoveUserById(int id)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    var removeId = new User { Id = id };
                    context.Entry(removeId).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public void AddOrUpdateArticle(Article article)
        {

            try
            {
                using (var context = new StoreDb())
                {


                    context.Entry(article).State = article.Articleid == 0 ? EntityState.Added : EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }

        public void AddOrUpdateOrder(Order order, List<OrderItem> orderlist)
        {
            try
            {
                using (var context = new StoreDb())
                {
                    if (order.OrderId == 0)
                    {
                        context.Entry(order).State = EntityState.Added;
                        context.SaveChanges();
                        orderlist.ForEach(o => o.fkOrderId = order.OrderId);
                        context.OrderItems.AddRange(orderlist);
                    }
                    else
                    {
                        context.Entry(order).State = EntityState.Modified;
                        context.OrderItems.RemoveRange(context.OrderItems.Where(o => o.fkOrderId == order.OrderId));
                        orderlist.ForEach(o => o.fkOrderId = order.OrderId);
                        context.OrderItems.AddRange(orderlist);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }

        }

        public List<Order> ReturnAllOrderByUser(string userName)
        {

            try
            {
                using (var context = new StoreDb())
                {
                    return context.Orders.Where(o => o.OrdedBy == userName).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.ToString());
            }
        }
    }
}
