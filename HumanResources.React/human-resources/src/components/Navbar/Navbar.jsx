import React from 'react';
import style from './Navbar.module.css';
import { NavLink } from 'react-router-dom';

const Navbar = () => {
    return (
        <ul className={style.menu}>
            <li className={style.link}>
                <NavLink activeClassName={style.active} to='/employees'>
                    Employees
              </NavLink>
            </li>
            <li className={style.link}>
                <NavLink activeClassName={style.active} to='/candidates'>
                    Candidates
              </NavLink>
            </li>
        </ul>
    );
}

export default Navbar;