import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <div class="columns">
                    <div class="column" style={{backgroundColor: "#FF0000"}}>1</div>
                    <div class="column is-one-fifth" style={{backgroundColor: "#FFFF00"}}>2</div>
                </div>
                <div class="columns">
                    <div class="column" style={{backgroundColor: "#FF00FF"}}>Bottom row</div>
                </div>
            </div>
        );
    }
}
