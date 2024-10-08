import { Layout, Menu } from "antd";
import "./globals.css";
import Link from "next/link";
import { Content, Footer, Header } from "antd/es/layout/layout";

const items = [
  { key: "home", label: <Link href={"/"}>Home</Link>}, 
  { key: "orders", label: <Link href={"/orders"}>Orders</Link>}

];


export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body>
        <Layout style={{minHeight:"100vh"}}>
          <Header>
            <Menu 
              theme="dark" 
              mode="horizontal" 
              items = {items} 
              style={{ flex: 1, minWitdth: 0 }}
              />
          </Header>
          <Content style={{ padding: "0 48px"}}>{children}</Content>
          <Footer style= {{ textAlign: "center" }}>Delivery orders</Footer>
        </Layout>
      </body>
    </html>
  );
}
