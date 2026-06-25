import {
    Routes,
    Route
}
    from "react-router-dom";

import Login from "./pages/Login";
import Dashboard from "./pages/Dashboard";
import Lockers from "./pages/Lockers";
import Packages from "./pages/Packages";
import ProtectedRoute from "./components/ProtectedRoute";

export default function App() {

    return (

        <Routes>

            <Route
                path="/"
                element={<Login />}
            />

            <Route
                path="/dashboard"
                element={
                    <ProtectedRoute>
                        <Dashboard />
                    </ProtectedRoute>
                }
            />

            <Route
                path="/lockers"
                element={
                    <ProtectedRoute>
                        <Lockers />
                    </ProtectedRoute>
                }
            />

            <Route
                path="/packages"
                element={
                    <ProtectedRoute>
                        <Packages />
                    </ProtectedRoute>
                }
            />

        </Routes>
    );
}