"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var react_1 = require("react");
var React = require("react");
var reactstrap_1 = require("reactstrap");
var react_router_dom_1 = require("react-router-dom");
var LoginMenu_1 = require("../api-authorization/LoginMenu");
var AdminMenu_1 = require("./AdminMenu");
require("./NavMenu.css");
function NavMenu(props) {
    var _a = react_1.useState(false), isOpen = _a[0], setIsOpen = _a[1];
    function toggle() {
        setIsOpen(!isOpen);
    }
    ;
    return (React.createElement("header", null,
        React.createElement(reactstrap_1.Navbar, { className: "navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3" },
            React.createElement(reactstrap_1.Container, null,
                React.createElement(reactstrap_1.NavbarBrand, { tag: react_router_dom_1.Link, to: "/" }, "World Doom League"),
                React.createElement(reactstrap_1.NavbarToggler, { onClick: toggle, className: "mr-2" }),
                React.createElement(reactstrap_1.Collapse, { className: "d-sm-inline-flex flex-sm-row-reverse", isOpen: isOpen, navbar: true },
                    React.createElement(reactstrap_1.Nav, { className: "navbar-nav flex-grow container-fluid", navbar: true },
                        React.createElement(reactstrap_1.NavItem, null,
                            React.createElement(reactstrap_1.NavLink, { tag: react_router_dom_1.Link, className: "text-dark", to: "/matches" }, "Matches")),
                        React.createElement(reactstrap_1.NavItem, null,
                            React.createElement(reactstrap_1.NavLink, { tag: react_router_dom_1.Link, className: "text-dark", to: "/results" }, "Results")),
                        React.createElement(reactstrap_1.UncontrolledDropdown, { nav: true, inNavbar: true },
                            React.createElement(reactstrap_1.DropdownToggle, { className: "text-dark", nav: true, caret: true }, "Seasons"),
                            React.createElement(reactstrap_1.DropdownMenu, { right: true },
                                React.createElement(reactstrap_1.DropdownItem, { header: true }, "Current Seasons"),
                                React.createElement(reactstrap_1.DropdownItem, { divider: true }),
                                React.createElement(reactstrap_1.DropdownItem, null, "WDL Winter 2019"),
                                React.createElement(reactstrap_1.DropdownItem, { divider: true }),
                                React.createElement(reactstrap_1.DropdownItem, null, "Previous Seasons"),
                                React.createElement(reactstrap_1.DropdownItem, { divider: true }))),
                        React.createElement(reactstrap_1.NavItem, null,
                            React.createElement(reactstrap_1.NavLink, { tag: react_router_dom_1.Link, className: "text-dark", to: "/stats" }, "Stats")),
                        React.createElement(reactstrap_1.NavItem, null,
                            React.createElement(reactstrap_1.NavLink, { tag: react_router_dom_1.Link, className: "text-dark", to: "/players" }, "Players")),
                        React.createElement(reactstrap_1.NavItem, null,
                            React.createElement(reactstrap_1.NavLink, { tag: react_router_dom_1.Link, className: "text-dark", to: "/demos" }, "Demos")),
                        React.createElement(AdminMenu_1.default, null),
                        React.createElement(LoginMenu_1.LoginMenu, null)))))));
}
exports.default = NavMenu;
//# sourceMappingURL=NavMenu.js.map