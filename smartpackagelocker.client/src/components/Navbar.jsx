import { Link } from "react-router-dom";

export default function Navbar() {

    return (
        <nav>

            <Link to="/dashboard">
                Dashboard
            </Link>

            {" | "}

            <Link to="/lockers">
                Lockers
            </Link>

            {" | "}

            <Link to="/packages">
                Packages
            </Link>

        </nav>
    );
}