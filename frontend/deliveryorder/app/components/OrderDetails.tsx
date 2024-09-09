import React from 'react';
import { Modal } from 'antd';

interface Props {
    order: Order;
    onClose: () => void;
}

export const OrderDetail = ({ order, onClose }: Props) => {
    return (
        <Modal
            title={`Order Details - ${order.id}`}
            visible={true}
            onCancel={onClose}
            footer={null}
        >
            <p><strong>Sender City:</strong> {order.senderCity}</p>
            <p><strong>Sender Address:</strong> {order.senderAddress}</p>
            <p><strong>Recipient City:</strong> {order.recipientCity}</p>
            <p><strong>Recipient Address:</strong> {order.recipientAddress}</p>
            <p><strong>Weight:</strong> {order.weight}</p>
            <p><strong>Pickup Date:</strong> {order.pickUpDate}</p>
        </Modal>
    );
};
