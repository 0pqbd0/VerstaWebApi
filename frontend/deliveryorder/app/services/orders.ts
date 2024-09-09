export interface OrderRequest {
    senderCity: string;
    senderAddress: string;
    recipientCity: string;
    recipientAddress: string;
    weight: number;
    pickUpDate: string;
}

export const getAllOrders = async () => {
    const response = await fetch("https://localhost:7235/api/Orders");

    return response.json();
}

export const createOrder = async (orderrequest: OrderRequest) => {
    await fetch("https://localhost:7235/api/Orders", 
        {
            method: "POST",
            headers: {
                "content-type": "application/json"
            },
            body: JSON.stringify(orderrequest),
        });
}

export const deleteOrder = async (id: string) => {
    await fetch(`https://localhost:7235/api/Orders/${id}`, 
        {
            method: "DELETE",
        });
}