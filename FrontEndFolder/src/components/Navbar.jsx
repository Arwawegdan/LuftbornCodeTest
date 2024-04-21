const navbarLinks = [
    {id: 1, path: 'all-tasks', label: 'your tasks'},
    {id: 2, path: 'in-progress', label: 'in progress'},
    {id: 3, path: 'finished', label: 'finished'},
]

function Navbar() {
    return (
        <header className="bg-white border-b max-w-[1340px] mx-auto">
            <div className="mx-auto flex h-16 max-w-screen-xl items-center gap-8 px-4 sm:px-6 lg:px-8">
                <div className="flex flex-1 items-center justify-end md:justify-between">
                    <nav aria-label="Global" className="hidden md:block">
                        <ul className="flex items-center gap-6 text-sm">
                            {navbarLinks?.map(navlink => (
                                <li key={navlink.id}>
                                    <a className="text-gray-500 transition hover:text-gray-500/75 capitalize" href={navlink.path}>{navlink.label}</a>
                                </li>
                            ))}
                        </ul>
                    </nav>

                    <div className="flex items-center gap-4">
                        <div className="sm:flex sm:gap-4">
                            <a
                                className="block rounded-md bg-primary px-5 py-2.5 text-sm font-medium text-white transition hover:bg-secondary"
                                href="#"
                            >
                                Login
                            </a>

                            <a
                                className="hidden rounded-md bg-gray-100 px-5 py-2.5 text-sm font-medium text-primary transition hover:text-secondary sm:block"
                                href="#"
                            >
                                Register
                            </a>
                        </div>

                        <button
                            className="block rounded bg-gray-100 p-2.5 text-gray-600 transition hover:text-gray-600/75 md:hidden"
                        >
                            <span className="sr-only">Toggle menu</span>
                            <svg
                                xmlns="http://www.w3.org/2000/svg"
                                className="h-5 w-5"
                                fill="none"
                                viewBox="0 0 24 24"
                                stroke="currentColor"
                                strokeWidth="2"
                            >
                                <path strokeLinecap="round" strokeLinejoin="round" d="M4 6h16M4 12h16M4 18h16" />
                            </svg>
                        </button>
                    </div>
                </div>
            </div>
        </header>
    )
}

export default Navbar