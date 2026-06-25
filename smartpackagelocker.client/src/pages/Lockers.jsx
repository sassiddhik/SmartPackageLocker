import { useEffect, useState } from "react";
import api from "../services/api";
import Navbar from "../components/Navbar";

export default function Lockers() {

    const [lockers, setLockers] =
        useState([]);

    useEffect(() => {

        api.get("/locker")
            .then(r =>
                setLockers(r.data));

    }, []);

    return (
        <>
            <Navbar />

            <h2>Lockers</h2>

            <table>

                <thead>
                    <tr>
                        <th>No</th>
                        <th>Status</th>
                    </tr>
                </thead>

                <tbody>

                    {lockers.map(x => (

                        <tr key={x.id}>
                            <td>{x.lockerNumber}</td>
                            <td>{x.status}</td>
                        </tr>

                    ))}

                </tbody>

            </table>
        </>
    );
}