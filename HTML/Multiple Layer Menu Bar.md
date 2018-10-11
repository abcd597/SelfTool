>網路上找到的Bootstrap的多層NavBar，之後建立MasterPage選單列時可以用~
>當初找到時是用Bootstrap v3.3.7版寫的，下面的是改成Bootstrap4之後的

#### CSS & SCSS  
css:  
```css
    .dropdown-submenu {
    position: relative;
	  }

    .dropdown-submenu > .dropdown-menu {
        top: 0;
        left: 100%;
        margin-top: -6px;
        margin-left: -1px;
        -webkit-border-radius: 0 6px 6px 6px;
        -moz-border-radius: 0 6px 6px;
        border-radius: 0 6px 6px 6px;
    }

    .dropdown-submenu:hover > .dropdown-menu {
        display: block;
    }

    .dropdown-submenu > a:after {
        display: block;
        content: " ";
        float: right;
        width: 0;
        height: 0;
        border-color: transparent;
        border-style: solid;
        border-width: 5px 0 5px 5px;
        border-left-color: #ccc;
        margin-top: 5px;
    }

    .dropdown-submenu:hover > a:after {
        border-left-color: #fff;
    }

    .dropdown-submenu.pull-left {
        float: none;
    }

        .dropdown-submenu.pull-left > .dropdown-menu {
            left: -100%;
            margin-left: 10px;
            -webkit-border-radius: 6px 0 6px 6px;
            -moz-border-radius: 6px 0 6px 6px;
            border-radius: 6px 0 6px 6px;
        }

	.navbar-expand-lg .navbar-nav > .open > a {
    background-color: white;
	}

    .navbar-expand-lg .navbar-nav > .open > a:hover, .navbar-expand-lg .navbar-nav > .open > a:focus {
        background-color: white;
    }
```
scss版(自己改的):
```scss
$radius6: 6px;
.dropdown-submenu {
    position: relative;

    > .dropdown-menu {
        top: 0;
        left: 100%;

        margin: {
            top: -6px;
            left: -1px;
        }

        -webkit-border-radius: 0 $radius6 $radius6 $radius6;
        -moz-border-radius: 0 $radius6 $radius6;
        border-radius: 0 $radius6 $radius6 $radius6;
    }

    &:hover > .dropdown-menu {
        display: block;
    }

    > a:after {
        display: block;
        content: " ";
        float: right;
        width: 0;
        height: 0;

        border: {
            color: transparent;
            style: solid;
            width: 5px 0 5px 5px;
            left-color: #ccc;
        }

        margin-top: 5px;
    }

    &:hover > a:after {
        border-left-color: #fff;
    }

    &.pull-left {
        float: none;

        > .dropdown-menu {
            left: -100%;
            margin-left: 10px;
            -webkit-border-radius: $radius6 0 $radius6 $radius6;
            -moz-border-radius: $radius6 0 $radius6 $radius6;
            border-radius: $radius6 0 $radius6 $radius6;
        }
    }
}

.navbar-expand-lg .navbar-nav {
    > .open > a {
        background-color: white;

        &:hover, &:focus {
            background-color: white;
        }
    }
}
```   
#### Html:
```HTML
<div class="navbar navbar-expand-lg navbar-light bg-light fixed-top" style="background-color: #e3f2fd;" role="navigation">
        <div class="navbar-header">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#n-content" aria-controls="n-content" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <a class="navbar-brand" href="#">Logo Text</a>
        </div>
        <div class="collapse navbar-collapse" id="n-content">
            <ul class="navbar-nav">
                <li class="nav-item"><a class="nav-link" href="#">MainPage</a></li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m1">Link1 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m1">
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-1</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-2</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-3</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-4</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-5</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-6</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-7</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link1-8</a></li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m2">Link2 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m2">
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m2-1">Link2-1</a>
                            <ul class="dropdown-menu" aria-labelledby="m2-1">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-1-1</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-1-2</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-1-3</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-1-4</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-1-5</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-1-6</a></li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" id="m2-2">Link2-2</a>
                            <ul class="dropdown-menu" aria-labelledby="m2-2">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-1</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-2</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-3</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-4</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-5</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-6</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-7</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-2-8</a></li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" id="m2-3">Link2-3</a>
                            <ul class="dropdown-menu" aria-labelledby="m2-3">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link2-3-1</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3">Link3 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m3">
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-1">Link3-1</a>
                            <ul class="dropdown-menu" aria-labelledby="m3-1">
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-1-1">Link3-1-1</a>
                                    <ul class="dropdown-menu" aria-labelledby="m3-1-1">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-1-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-1-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-1-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-1-4</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-1-5</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-1-6</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-1-2">Link3-1-2</a>
                                    <ul class="dropdown-menu" aria-labelledby="m3-1-2">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-2-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-1-3">Link3-1-3</a>
                                    <ul class="dropdown-menu" aria-labelledby="m3-1-3">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-4</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-5</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-6</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-7</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-8</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-9</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-1-3-10</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-2">Link3-2</a>
                            <ul class="dropdown-menu" aria-labelledby="m3-2">
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" id="m3-2-1">Link3-2-1</a>
                                    <ul class="dropdown-menu">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-1-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-1-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-1-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-1-4</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-1-5</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-1-6</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-2-2">Link3-2-2</a>
                                    <ul class="dropdown-menu" aria-labelledby="m3-2-2">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-2-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-2-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-2-3</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m3-2-3">Link3-2-3</a>
                                    <ul class="dropdown-menu" aria-labelledby="m3-2-3">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-4</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-5</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-6</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-7</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-8</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-9</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-10</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-11</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link3-2-3-12</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m4">Link4 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m4">
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m4-1">Link4-1</a>
                            <ul class="dropdown-menu" aria-labelledby="m4-1">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-1</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-2</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-3</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-4</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-5</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-6</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-1-7</a></li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m4-2">Link4-2</a>
                            <ul class="dropdown-menu" aria-labelledby="m4-2">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-1</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-2</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-3</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-4</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-5</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-6</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-7</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-8</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-9</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link4-2-10</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5">Link5 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m5">
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1">Link5-1</a>
                            <ul class="dropdown-menu" aria-labelledby="m5-1">
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-1">Link5-1-1</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-1">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-1-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-1-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-1-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-1-4</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-1-5</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-2">Link5-1-2</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-2">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-2-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-2-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-2-3</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-3">Link5-1-3</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-3">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-3-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-4">Link5-1-4</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-4">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-4-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-5">Link5-1-5</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-5">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-5-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-6">Link5-1-6</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-6">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-6-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-7">Link5-1-7</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-7">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-7-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-8">Link5-1-8</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-8">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-8-1</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-9">Link5-1-9</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-9">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-9-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-9-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-9-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-9-4</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-9-5</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-9-6</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-1-10">Link5-1-10</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-1-10">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-10-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-10-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-10-3</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-1-10-4</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-2">Link5-2</a>
                            <ul class="dropdown-menu" aria-labelledby="m5-2">
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-2-1">Link5-2-1</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-2-1">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-1-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-1-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-1-3</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m5-2-2">Link5-2-2</a>
                                    <ul class="dropdown-menu" aria-labelledby="m5-2-2">
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-2-1</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-2-2</a></li>
                                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-2-3</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-3</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-4</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-5</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-6</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-7</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-8</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-9</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-10</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link5-2-11</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m6">Link6  <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m6">
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m6-1">Link6-1</a>
                            <ul class="dropdown-menu" aria-labelledby="m6-1">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-1-1</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-1-2</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-1-3</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-1-4</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-1-5</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-1-6</a></li>
                            </ul>
                        </li>
                        <li class="dropdown-submenu">
                            <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m6-2">Link6-2</a>
                            <ul class="dropdown-menu" aria-labelledby="m6-2">
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-2-1</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-2-2</a></li>
                                <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link6-2-3</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m7">Link7 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m7">
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link7-1</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link7-2</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link7-3</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link7-4</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link7-5</a></li>
                    </ul>
                </li>
                <li class="nav-item dropdown">
                    <a href="#" class="dropdown-toggle nav-link" data-toggle="dropdown" role="button" id="m8">Link8 <b class="caret"></b></a>
                    <ul class="dropdown-menu" aria-labelledby="m8">
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link8-1</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link8-2</a></li>
                        <li class="dropdown-item pl-0"><a class="nav-link" href="#">Link8-3</a></li>
                    </ul>
                </li>
            </ul>
        </div>
        <ul class="navbar-nav mr-0">
            <li class="nav-item nav"><a class="nav-link" href="#">Logout&nbsp;&nbsp;<i class="fas fa-sign-out-alt"></i></a></li>&nbsp;&nbsp;
        </ul>
        <!--/.nav-collapse -->
    </div>
```
