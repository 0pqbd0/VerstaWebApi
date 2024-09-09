import { OrderRequest } from "../services/orders";
import React from 'react';
import { Modal, Input, Form, Button } from 'antd';

interface Props {
    values: Order[];
    isModalOpen: boolean;
    handleCancel: () => void;
    handleCreate: (request: OrderRequest) => void;
}

export const CreateOrder = ({
    isModalOpen,
    handleCancel,
    handleCreate
}: Props) => {
    const [form] = Form.useForm();

    const handleSubmit = () => {
        form.validateFields()
            .then((values) => {
                handleCreate(values as OrderRequest);
                form.resetFields();
            })
            .catch((info) => {
                console.log('Validation Failed:', info);
            });
    };

    return (
        <Modal 
            title={"Add delivery order"} 
            open={isModalOpen} 
            onCancel={handleCancel}
            footer={[
                <Button key="back" onClick={handleCancel}>
                    Cancel
                </Button>,
                <Button key="submit" type="primary" onClick={handleSubmit}>
                    Create
                </Button>,
            ]}
        >
            <div className="order_modal">
                <Form form={form} layout="vertical">
                    <Form.Item label="Sender City" name="senderCity" rules={[{ required: true, message: 'Please input the sender city!' }]}>
                        <Input />
                    </Form.Item>
                    <Form.Item label="Sender Address" name="senderAddress" rules={[{ required: true, message: 'Please input the sender address!' }]}>
                        <Input />
                    </Form.Item>
                    <Form.Item label="Recipient City" name="recipientCity" rules={[{ required: true, message: 'Please input the recipient city!' }]}>
                        <Input />
                    </Form.Item>
                    <Form.Item label="Recipient Address" name="recipientAddress" rules={[{ required: true, message: 'Please input the recipient address!' }]}>
                        <Input />
                    </Form.Item>
                    <Form.Item label="Weight" name="weight" rules={[{ required: true, message: 'Please input the weight!' }]}>
                        <Input type="number" />
                    </Form.Item>
                    <Form.Item label="Pickup Date" name="pickUpDate" rules={[{ required: true, message: 'Please select the pickup date!' }]}>
                        <Input type="date" />
                    </Form.Item>
                </Form>
            </div>
        </Modal>
    );
};
