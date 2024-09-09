interface Props {
    recipientAdress: string;
}

export const CardTitle = ({recipientAdress}:Props) => {
    return (
        <div style={{
            display: "flex",
            flexDirection: "row",
            alignItems: "center",
            justifyContent: "space-between",
        }}>
            <p className="card_recipient_adress">{recipientAdress}</p>
        </div>
    )
}