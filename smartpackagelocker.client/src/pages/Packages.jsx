import { useState } from "react";
import api from "../services/api";
import Navbar from "../components/Navbar";

export default function Packages() {

    const [trackingNumber, setTracking] =
        useState("");

    const [recipientName, setRecipient] =
        useState("");

    const [lockerId, setLockerId] =
        useState("");

    const save = async () => {

        const response =
            await api.post(
                "/package/assign",
                {
                    trackingNumber,
                    recipientName,
                    lockerId
                });

        alert(
            "Pickup Code: " +
            response.data.pickupCode
        );
    };

    return (
        <>
            <Navbar />

            <h2>Assign Package</h2>

            <input
                placeholder="Tracking Number"
                onChange={(e) =>
                    setTracking(e.target.value)}
            />

            <br />

            <input
                placeholder="Recipient"
                onChange={(e) =>
                    setRecipient(e.target.value)}
            />

            <br />

            <input
                placeholder="Locker Id"
                onChange={(e) =>
                    setLockerId(e.target.value)}
            />

            <br />

            <button onClick={save}>
                Assign Package
            </button>
        </>
    );
}