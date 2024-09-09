"use client"

import Button from "antd/es/button/button";
import { useEffect, useState } from "react";
import { getAllOrders, createOrder, deleteOrder, OrderRequest } from "../services/orders";
import { Orders } from "../components/Orders";
import Title from "antd/es/skeleton/Title";
import { CreateOrder } from "../components/CreateOrder";
import { OrderDetail } from "../components/OrderDetails";

export default function OrdersPage() {
    const [orders, setOrders] = useState<Order[]>([]);
    const [loading, setLoading] = useState(true);
    const [isModalOpen, setIsModalOpen] = useState(false);
    const [selectedOrder, setSelectedOrder] = useState<Order | null>(null);
    
    useEffect(() => {
        const fetchOrders = async () => {
            setLoading(true);
            const orders = await getAllOrders();
            setOrders(orders);
            setLoading(false);
        };

        fetchOrders();
    }, []);

    const handleCreateOrder = async (orderRequest: OrderRequest) => {
        await createOrder(orderRequest);
        const updatedOrders = await getAllOrders();
        setOrders(updatedOrders);
        setIsModalOpen(false);
    };

    const handleOrderClick = (order: Order) => {
        setSelectedOrder(order);  
    };

    const handleOrderDetailClose = () => {
        setSelectedOrder(null);
    };

    const handleDeleteOrder = async (id: string) => {
        await deleteOrder(id);
        const updatedOrders = await getAllOrders();
        setOrders(updatedOrders);
    };

    return (
        <div>
            <Button onClick={() => setIsModalOpen(true)}>Add delivery order</Button>

            <CreateOrder
                isModalOpen={isModalOpen}
                handleCancel={() => setIsModalOpen(false)}
                handleCreate={handleCreateOrder}
                values={[]}
            />

            {loading ? (
                <Title>Loading.....</Title>
            ) : (
                <Orders
                    orders={orders}
                    onOrderClick={handleOrderClick}
                    onDeleteOrder={handleDeleteOrder}
                />
            )}

            {selectedOrder && (
                <OrderDetail
                    order={selectedOrder}
                    onClose={handleOrderDetailClose}
                />
            )}
        </div>
    );
}


