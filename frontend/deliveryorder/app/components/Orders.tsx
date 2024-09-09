import Card from "antd/es/card/Card"
import { Button } from 'antd';
import React from 'react';
import { CardTitle } from './Cardtitle';

interface Props {
    orders: Order[];
    onOrderClick: (order: Order) => void;
    onDeleteOrder: (id: string) => void;
}

export const Orders = ({ orders, onOrderClick, onDeleteOrder }: Props) => {
    return (
        <div className="cards">
            {orders.map((order: Order) => (
                <Card
                    key={order.id}
                    title={<CardTitle recipientAdress={order.recipientAddress} />}
                    bordered={false}
                    onClick={() => onOrderClick(order)}
                    style={{ cursor: 'pointer' }}
                >
                    <p>{order.id}</p>
                    <div className="card_buttons">
                        <Button onClick={(e: React.MouseEvent<HTMLButtonElement>) => {
                            e.stopPropagation();
                            onDeleteOrder(order.id);
                        }}>
                            Delete
                        </Button>
                    </div>
                </Card>
            ))}
        </div>
    );
};
