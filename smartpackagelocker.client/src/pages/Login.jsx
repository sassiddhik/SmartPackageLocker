import { useState } from "react";
import api from "../services/api";
import { useNavigate } from "react-router-dom";

export default function Login() {

    const [email, setEmail] =
        useState("");

    const [password, setPassword] =
        useState("");

    const navigate = useNavigate();

    const login = async () => {

        const response =
           await api.post(
               "/auth/login",
               {
                   email,
                   password
               });

        localStorage.setItem(
           "token",
           response.data
        );

        navigate("/dashboard");
    };

    return (
        <div>

            <h2>Login</h2>

            <input
                placeholder="Email"
                onChange={(e) =>
                    setEmail(e.target.value)}
            />

            <br />

            <input
                type="password"
                placeholder="Password"
                onChange={(e) =>
                    setPassword(e.target.value)}
            />

            <br />

            <button onClick={login}>
                Login
            </button>

        </div>
    );
}